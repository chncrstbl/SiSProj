Imports MySql.Data.MySqlClient
Public Class LoginScreen
    Private passwordVisible As Boolean = False

    Private Sub LoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()

        SetDefaultIcon(Me)

        Me.ActiveControl = txtUserN

        SetRoundedCorners(Me, 30)

        SetRoundedCorners(Panel1, 10)
        SetRoundedCorners(Panel2, 10)
        SetRoundedCorners(Panel3, 10)

        bttnReveal.Visible = False
        txtPass.PasswordChar = "•"
        bttnReveal.BackgroundImage = My.Resources.closed_eye_512x512
        passwordVisible = False

        bttnReveal.FlatStyle = FlatStyle.Flat
        bttnReveal.FlatAppearance.BorderSize = 0
        bttnReveal.FlatAppearance.MouseOverBackColor = Color.Transparent
        bttnReveal.FlatAppearance.MouseDownBackColor = Color.Transparent
        bttnReveal.BackColor = Color.Transparent
    End Sub


    Private Sub txtUserN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUserN.KeyDown

        If e.KeyCode = Keys.Enter Then
            If txtUserN.Text = "" Then
                MessageBox.Show("Please enter your username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUserN.Focus()
            Else
                txtPass.Focus()
            End If
        End If

    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown

        If e.KeyValue = Keys.Enter Then
            If txtPass.Text = "" Then
                MessageBox.Show("Please enter your password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPass.Focus()
            Else
                loginBttn.PerformClick()
            End If
        End If

    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        bttnReveal.Visible = txtPass.Text.Length > 0
    End Sub

    Private Sub bttnReveal_Click(sender As Object, e As EventArgs) Handles bttnReveal.Click
        If passwordVisible Then
            ' Hide password
            txtPass.PasswordChar = "•"
            bttnReveal.BackgroundImage = My.Resources.closed_eye_512x512
            passwordVisible = False
        Else
            ' Show password
            txtPass.PasswordChar = ControlChars.NullChar
            bttnReveal.BackgroundImage = My.Resources.open_eye_512x512
            passwordVisible = True
        End If
    End Sub

    Private Sub cancelBttn_Click(sender As Object, e As EventArgs) Handles cancelBttn.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub loginBttn_Click(sender As Object, e As EventArgs) Handles loginBttn.Click

        cn.Open()
        cm = New MySqlCommand("select * from tblsecurity where username like '" + txtUserN.Text + "' and password like '" + txtPass.Text + "'", cn)
        dr = cm.ExecuteReader

        If dr.Read Then

            If txtUserN.Text.Equals(dr.Item(1).ToString) And txtPass.Text.Equals(dr.Item(2).ToString) Then
                With MainInt
                    MsgBox("Access Granted!", vbInformation)
                    .Show()
                    Me.Hide()
                    cn.Close()
                    dr.Close()
                    MainInt.Show()
                End With
            End If
        Else
            MsgBox("Access Denied!", vbInformation)
            txtUserN.Clear()
            txtPass.Clear()
            txtUserN.Focus()
        End If

        cn.Close()
        dr.Close()

        'Try
        '    cn.Open()
        '    MessageBox.Show("Connection to MySQL test database was successful!!!!", "TESTING      CONNECTION TO MySQL DATABASE")
        '    cn.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    cn.Close()
        'End Try

    End Sub
End Class
