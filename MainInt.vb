Imports MySql.Data.MySqlClient
Imports Mysqlx.Cursor

Public Class MainInt


    Private Sub MainInt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Connect to DB
        'and
        'Load Data
        connection()
        LoadData()

        SetDefaultIcon(Me)

        Label1.BackColor = Color.Transparent
        Panel2.BackColor = Color.Transparent

        bttnSearch.FlatStyle = FlatStyle.Flat
        bttnSearch.FlatAppearance.BorderSize = 0
        bttnSearch.FlatAppearance.MouseOverBackColor = Color.Transparent
        bttnSearch.FlatAppearance.MouseDownBackColor = Color.Transparent
        bttnSearch.BackColor = Color.Transparent
    End Sub


    Private Sub bttnExit_Click(sender As Object, e As EventArgs) Handles bttnExit.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit? You will be logged out of the system.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Dispose()
            LoginScreen.Show()
        End If

    End Sub

    Private Sub bttnEdit_Click(sender As Object, e As EventArgs) Handles bttnEdit.Click
        Dim entryForm As New EntryForm()

        AddHandler entryForm.DataSaved, AddressOf RefreshTable

        entryForm.Show()
    End Sub


    Private Sub RefreshTable()
        ' Refresh the data in the DataGridView
        LoadData()
    End Sub


    Sub LoadData()

        Dim i As Integer = 0
        cn.Open()
        cm = New MySqlCommand("select * from tblinfor", cn)
        dtStudentDS.Rows.Clear()
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            dtStudentDS.Rows.Add(i,
                                 dr.Item(1).ToString,
                                 dr.Item(2).ToString,
                                 dr.Item(3).ToString,
                                 dr.Item(4).ToString,
                                 dr.Item(5).ToString,
                                 dr.Item(6).ToString,
                                 dr.Item(7).ToString,
                                 dr.Item(8).ToString,
                                 dr.Item(9).ToString,
                                 dr.Item(10).ToString,
                                 dr.Item(11).ToString)

        End While
        dr.Close()
        cn.Close()


        dtStudentDS.ClearSelection()
    End Sub


    Private Sub bttnSearch_Click(sender As Object, e As EventArgs) Handles bttnSearch.Click
        Dim searchTerm As String = txtbxSearch.Text.Trim()

        If String.IsNullOrEmpty(searchTerm) Then
            LoadData()
            Return
        End If

        Try
            dtStudentDS.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM tblinfor WHERE
            `studID` LIKE @searchTerm OR
            `lastname` LIKE @searchTerm OR
            `firstname` LIKE @searchTerm OR
            `middlename` LIKE @searchTerm OR
            `year` LIKE @searchTerm OR
            `program` LIKE @searchTerm OR
            `section` LIKE @searchTerm OR
            `gender` LIKE @searchTerm OR
            `birthdate` LIKE @searchTerm OR
            `religion` LIKE @searchTerm OR
            `address` LIKE @searchTerm", cn)
            cm.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")
            dr = cm.ExecuteReader()

            Dim i As Integer = 0
            While dr.Read
                i += 1
                dtStudentDS.Rows.Add(i,
                                     dr.Item(1).ToString,
                                     dr.Item(2).ToString,
                                     dr.Item(3).ToString,
                                     dr.Item(4).ToString,
                                     dr.Item(5).ToString,
                                     dr.Item(6).ToString,
                                     dr.Item(7).ToString,
                                     dr.Item(8).ToString,
                                     dr.Item(9).ToString,
                                     dr.Item(10).ToString,
                                     dr.Item(11).ToString)
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred while searching: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Panel1.Click, Panel2.Click, Panel3.Click
        dtStudentDS.ClearSelection()
    End Sub

    Private Sub bttnImport_Click(sender As Object, e As EventArgs) Handles bttnImport.Click
        Dim importForm As New ImportForm()
        AddHandler importForm.DataSaved, AddressOf RefreshTable
        importForm.Show()
    End Sub

    Private Sub txtbxSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbxSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            bttnSearch_Click(bttnSearch, EventArgs.Empty)
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If dtStudentDS.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = dtStudentDS.SelectedRows(0)
        Dim studID As String = selectedRow.Cells(1).Value.ToString()

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                cn.Open()
                cm = New MySqlCommand("DELETE FROM tblinfor WHERE studID = @studID", cn)
                cm.Parameters.AddWithValue("@studID", studID)
                cm.ExecuteNonQuery()
                cn.Close()
                MessageBox.Show("Record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
            Catch ex As Exception
                If cn.State = ConnectionState.Open Then cn.Close()
                MessageBox.Show("An error occurred while deleting: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class