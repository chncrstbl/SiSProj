<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EntryForm))
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        GroupBox2 = New GroupBox()
        cbProgram = New ComboBox()
        cbYearLevel = New ComboBox()
        txtSection = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtStudentID = New TextBox()
        Label12 = New Label()
        GroupBox1 = New GroupBox()
        dtBirth = New DateTimePicker()
        cbReligion = New ComboBox()
        cbGender = New ComboBox()
        txtAddress = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        txtMName = New TextBox()
        txtFName = New TextBox()
        txtLName = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        bttnClear = New Button()
        bttnCancel = New Button()
        bttnSave = New Button()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(51), CByte(102))
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(975, 104)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Calisto MT", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(24, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 50)
        Label1.TabIndex = 1
        Label1.Text = "Register"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLight
        Panel2.Controls.Add(GroupBox2)
        Panel2.Controls.Add(GroupBox1)
        Panel2.Controls.Add(bttnClear)
        Panel2.Controls.Add(bttnCancel)
        Panel2.Controls.Add(bttnSave)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 104)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(975, 796)
        Panel2.TabIndex = 2
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cbProgram)
        GroupBox2.Controls.Add(cbYearLevel)
        GroupBox2.Controls.Add(txtSection)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(txtStudentID)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Location = New Point(488, 24)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(456, 688)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "School Info"
        ' 
        ' cbProgram
        ' 
        cbProgram.Cursor = Cursors.Hand
        cbProgram.DropDownHeight = 100
        cbProgram.DropDownStyle = ComboBoxStyle.DropDownList
        cbProgram.DropDownWidth = 450
        cbProgram.FormattingEnabled = True
        cbProgram.IntegralHeight = False
        cbProgram.Items.AddRange(New Object() {"ABCom – Bachelor of Arts in Communication (Masscom)", "ABEng – Bachelor of Arts in English", "BSM – Bachelor of Sciences in Mathematics", "BSP – Bachelor of Sciences in Psychology", "ABA – Associate in Business Administration", "BSAIS – Bachelor of Science in Accounting Information System", "BSA – Bachelor of Science in Accountancy", "BSMA – Bachelor of Science in Management Accounting", "BSREM – Bachelor of Science in Real Estate Management", "BSIA – Bachelor of Science in Internal Auditing", "BSBA – Bachelor of Science in Business Administration", "ACT – Associate in Computer Technology", "BSCS – Bachelor of Science in Computer Science", "BSIT – Bachelor of Science in Information Technology", "BSIS – Bachelor of Science in Information System", "BECEd – Bachelor in Early Childhood Education", "BEEd – Bachelor in Elementary Education", "BSEd – Bachelor in Secondary Education", "BSMT – Bachelor of Science in Marine Transportation", "BSC – Bachelor of Science in Criminology", "BSSIM – Bachelor of Science in Industrial Security Management", "BSPA – Bachelor of Science in Public Administration", "BSCE – Bachelor of Science in Computer Engineering", "BSELE – Bachelor of Science in Electronics Engineering", "BSMedTech – Bachelor of Science in Medical Technology", "BSHM – Bachelor of Science in Hospitality Management", "BSTM – Bachelor of Science in Tourism Management"})
        cbProgram.Location = New Point(112, 280)
        cbProgram.Name = "cbProgram"
        cbProgram.Size = New Size(320, 28)
        cbProgram.TabIndex = 10
        ' 
        ' cbYearLevel
        ' 
        cbYearLevel.Cursor = Cursors.Hand
        cbYearLevel.DropDownStyle = ComboBoxStyle.DropDownList
        cbYearLevel.FormattingEnabled = True
        cbYearLevel.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year", "5th Year"})
        cbYearLevel.Location = New Point(112, 216)
        cbYearLevel.Name = "cbYearLevel"
        cbYearLevel.Size = New Size(320, 28)
        cbYearLevel.TabIndex = 10
        ' 
        ' txtSection
        ' 
        txtSection.Cursor = Cursors.IBeam
        txtSection.Location = New Point(112, 344)
        txtSection.Name = "txtSection"
        txtSection.Size = New Size(320, 27)
        txtSection.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(72, 216)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 20)
        Label6.TabIndex = 7
        Label6.Text = "Year:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(48, 344)
        Label7.Name = "Label7"
        Label7.Size = New Size(61, 20)
        Label7.TabIndex = 6
        Label7.Text = "Section:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(40, 280)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 20)
        Label8.TabIndex = 5
        Label8.Text = "Program:"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Cursor = Cursors.IBeam
        txtStudentID.Location = New Point(112, 152)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(320, 27)
        txtStudentID.TabIndex = 9
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(31, 152)
        Label12.Name = "Label12"
        Label12.Size = New Size(82, 20)
        Label12.TabIndex = 5
        Label12.Text = "Student ID:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dtBirth)
        GroupBox1.Controls.Add(cbReligion)
        GroupBox1.Controls.Add(cbGender)
        GroupBox1.Controls.Add(txtAddress)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(txtMName)
        GroupBox1.Controls.Add(txtFName)
        GroupBox1.Controls.Add(txtLName)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(24, 24)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(456, 744)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Personal Info"
        ' 
        ' dtBirth
        ' 
        dtBirth.Cursor = Cursors.Hand
        dtBirth.Format = DateTimePickerFormat.Short
        dtBirth.Location = New Point(104, 392)
        dtBirth.Name = "dtBirth"
        dtBirth.RightToLeft = RightToLeft.No
        dtBirth.Size = New Size(320, 27)
        dtBirth.TabIndex = 11
        ' 
        ' cbReligion
        ' 
        cbReligion.Cursor = Cursors.Hand
        cbReligion.DropDownStyle = ComboBoxStyle.DropDownList
        cbReligion.FormattingEnabled = True
        cbReligion.Items.AddRange(New Object() {"Christian", "Catholic", "Muslim", "Born Again", "Iglesia ni Cristo"})
        cbReligion.Location = New Point(104, 520)
        cbReligion.Name = "cbReligion"
        cbReligion.Size = New Size(320, 28)
        cbReligion.TabIndex = 10
        ' 
        ' cbGender
        ' 
        cbGender.Cursor = Cursors.Hand
        cbGender.DropDownStyle = ComboBoxStyle.DropDownList
        cbGender.FormattingEnabled = True
        cbGender.Items.AddRange(New Object() {"Male", "Female", "Prefer not to say"})
        cbGender.Location = New Point(104, 456)
        cbGender.Name = "cbGender"
        cbGender.Size = New Size(320, 28)
        cbGender.TabIndex = 10
        ' 
        ' txtAddress
        ' 
        txtAddress.Cursor = Cursors.IBeam
        txtAddress.Location = New Point(105, 288)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(320, 72)
        txtAddress.TabIndex = 6
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(40, 520)
        Label11.Name = "Label11"
        Label11.Size = New Size(67, 20)
        Label11.TabIndex = 7
        Label11.Text = "Religion:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(8, 392)
        Label10.Name = "Label10"
        Label10.Size = New Size(97, 20)
        Label10.TabIndex = 7
        Label10.Text = "Date of Birth:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(48, 456)
        Label9.Name = "Label9"
        Label9.Size = New Size(60, 20)
        Label9.TabIndex = 7
        Label9.Text = "Gender:"
        ' 
        ' txtMName
        ' 
        txtMName.Cursor = Cursors.IBeam
        txtMName.Location = New Point(105, 224)
        txtMName.Name = "txtMName"
        txtMName.PlaceholderText = "(Optional)"
        txtMName.Size = New Size(320, 27)
        txtMName.TabIndex = 7
        ' 
        ' txtFName
        ' 
        txtFName.Cursor = Cursors.IBeam
        txtFName.Location = New Point(105, 160)
        txtFName.Name = "txtFName"
        txtFName.Size = New Size(320, 27)
        txtFName.TabIndex = 8
        ' 
        ' txtLName
        ' 
        txtLName.Cursor = Cursors.IBeam
        txtLName.Location = New Point(105, 96)
        txtLName.Name = "txtLName"
        txtLName.Size = New Size(320, 27)
        txtLName.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(40, 288)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 20)
        Label5.TabIndex = 2
        Label5.Text = "Address:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 3
        Label3.Text = "First Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(0, 224)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 20)
        Label4.TabIndex = 4
        Label4.Text = "Middle Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 20)
        Label2.TabIndex = 5
        Label2.Text = "Last Name:"
        ' 
        ' bttnClear
        ' 
        bttnClear.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        bttnClear.Cursor = Cursors.Hand
        bttnClear.FlatAppearance.BorderSize = 0
        bttnClear.FlatStyle = FlatStyle.Flat
        bttnClear.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bttnClear.ForeColor = Color.White
        bttnClear.Location = New Point(624, 728)
        bttnClear.Name = "bttnClear"
        bttnClear.Size = New Size(94, 40)
        bttnClear.TabIndex = 3
        bttnClear.Text = "Clear"
        bttnClear.UseVisualStyleBackColor = False
        ' 
        ' bttnCancel
        ' 
        bttnCancel.BackColor = Color.Red
        bttnCancel.Cursor = Cursors.Hand
        bttnCancel.FlatAppearance.BorderSize = 0
        bttnCancel.FlatStyle = FlatStyle.Flat
        bttnCancel.Font = New Font("Century Gothic", 12F)
        bttnCancel.ForeColor = Color.White
        bttnCancel.Location = New Point(736, 728)
        bttnCancel.Name = "bttnCancel"
        bttnCancel.Size = New Size(94, 40)
        bttnCancel.TabIndex = 3
        bttnCancel.Text = "Cancel"
        bttnCancel.UseVisualStyleBackColor = False
        ' 
        ' bttnSave
        ' 
        bttnSave.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        bttnSave.Cursor = Cursors.Hand
        bttnSave.FlatAppearance.BorderSize = 0
        bttnSave.FlatStyle = FlatStyle.Flat
        bttnSave.Font = New Font("Century Gothic", 12F)
        bttnSave.ForeColor = Color.White
        bttnSave.Location = New Point(848, 728)
        bttnSave.Name = "bttnSave"
        bttnSave.Size = New Size(94, 40)
        bttnSave.TabIndex = 3
        bttnSave.Text = "Save"
        bttnSave.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Panel2)
        Panel3.Controls.Add(Panel1)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(975, 900)
        Panel3.TabIndex = 3
        ' 
        ' EntryForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(975, 900)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.None
        Name = "EntryForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EntryForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bttnCancel As Button
    Friend WithEvents bttnSave As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbYearLevel As ComboBox
    Friend WithEvents txtSection As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtMName As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dtBirth As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents cbReligion As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents bttnClear As Button
    Friend WithEvents cbProgram As ComboBox
    Friend WithEvents Panel3 As Panel
End Class
