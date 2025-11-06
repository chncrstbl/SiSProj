Imports MySql.Data.MySqlClient
Public Class EntryForm


    Private Sub EntryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()

        SetDefaultIcon(Me)

        Label1.BackColor = Color.Transparent

        SetRoundedCorners(Me, 30)
        SetRoundedCorners(Panel3, 10)
    End Sub


    Public Event DataSaved()


    Private Sub bttnClear_Click(sender As Object, e As EventArgs) Handles bttnClear.Click
        txtStudentID.Clear()
        txtLName.Clear()
        txtFName.Clear()
        txtMName.Clear()
        txtAddress.Clear()
        dtBirth.ResetText()
        txtSection.Clear()
        txtStudentID.Clear()
        cbGender.SelectedIndex = -1
        cbYearLevel.SelectedIndex = -1
        cbProgram.SelectedIndex = -1
        cbReligion.SelectedIndex = -1
    End Sub


    Private Sub bttnUpdate_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub bttnCancel_Click(sender As Object, e As EventArgs) Handles bttnCancel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub


    Private Sub bttnSave_Click(sender As Object, e As EventArgs) Handles bttnSave.Click

        'Validates if all fields are filled
        Dim today As String = DateTime.Now.ToShortDateString
        If txtStudentID.Text.Equals("") OrElse
            txtLName.Text.Equals("") OrElse
            txtFName.Text.Equals("") OrElse
            txtAddress.Text.Equals("") OrElse
            dtBirth.Text.Equals(today) OrElse
            cbGender.Items.Equals("") OrElse
            cbYearLevel.Items.Equals("") OrElse
            cbProgram.Items.Equals("") OrElse
            txtSection.Text.Equals("") OrElse
            cbReligion.Items.Equals("") Then
            'txtMName.Text.Equals("") OrElse
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            Try
                cn.Open()
                cm = New MySqlCommand("insert into tblinfor 
        (studID, lastname, firstname, middlename, address, birthdate, gender, year, program, section, religion)
         values 
        (@StudentID, @LName, @FName, @MName, @Address, @Birth, @Gender, @YearLevel, @Program, @Section, @Religion)", cn)
                With cm.Parameters
                    .AddWithValue("@StudentID", txtStudentID.Text)
                    .AddWithValue("@LName", txtLName.Text)
                    .AddWithValue("@FName", txtFName.Text)
                    .AddWithValue("@MName", txtMName.Text)
                    .AddWithValue("@Address", txtAddress.Text)
                    .AddWithValue("@Birth", dtBirth.Value.ToString("yyyy-MM-dd"))
                    .AddWithValue("@Gender", cbGender.Text)
                    .AddWithValue("@YearLevel", cbYearLevel.Text)
                    .AddWithValue("@Program", cbProgram.Text)
                    .AddWithValue("@Section", txtSection.Text)
                    .AddWithValue("@Religion", cbReligion.Text)
                End With
                cm.ExecuteNonQuery()
                MessageBox.Show("Data has successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If cn.State = ConnectionState.Open Then cn.Close()
            End Try

            RaiseEvent DataSaved()
        End If
    End Sub


    Private Sub txtMName_Leave(sender As Object, e As EventArgs) Handles txtMName.Leave
        If txtMName.Text.Equals("") Then
            txtMName.PlaceholderText = "(Optional)"
            txtMName.ForeColor = Color.LightGray
        End If
    End Sub
End Class