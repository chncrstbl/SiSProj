<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportForm))
        dtStudentDS = New DataGridView()
        Col1 = New DataGridViewTextBoxColumn()
        Col2 = New DataGridViewTextBoxColumn()
        Col3 = New DataGridViewTextBoxColumn()
        Col4 = New DataGridViewTextBoxColumn()
        Col5 = New DataGridViewTextBoxColumn()
        Col6 = New DataGridViewTextBoxColumn()
        Col7 = New DataGridViewTextBoxColumn()
        Col8 = New DataGridViewTextBoxColumn()
        Col9 = New DataGridViewTextBoxColumn()
        Col10 = New DataGridViewTextBoxColumn()
        Col11 = New DataGridViewTextBoxColumn()
        Panel4 = New Panel()
        Panel1 = New Panel()
        Panel2 = New Panel()
        bttnImport = New Button()
        bttnSave = New Button()
        CType(dtStudentDS, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dtStudentDS
        ' 
        dtStudentDS.AllowUserToAddRows = False
        dtStudentDS.AllowUserToDeleteRows = False
        dtStudentDS.AllowUserToResizeColumns = False
        dtStudentDS.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = Color.DodgerBlue
        dtStudentDS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dtStudentDS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dtStudentDS.BackgroundColor = Color.WhiteSmoke
        dtStudentDS.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        dtStudentDS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.DodgerBlue
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9F)
        DataGridViewCellStyle2.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dtStudentDS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dtStudentDS.ColumnHeadersHeight = 25
        dtStudentDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dtStudentDS.Columns.AddRange(New DataGridViewColumn() {Col1, Col2, Col3, Col4, Col5, Col6, Col7, Col8, Col9, Col10, Col11})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9F)
        DataGridViewCellStyle3.ForeColor = Color.DodgerBlue
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dtStudentDS.DefaultCellStyle = DataGridViewCellStyle3
        dtStudentDS.Dock = DockStyle.Fill
        dtStudentDS.EnableHeadersVisualStyles = False
        dtStudentDS.GridColor = Color.DodgerBlue
        dtStudentDS.Location = New Point(0, 104)
        dtStudentDS.Name = "dtStudentDS"
        dtStudentDS.ReadOnly = True
        dtStudentDS.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.DodgerBlue
        DataGridViewCellStyle4.Font = New Font("Century Gothic", 9F)
        DataGridViewCellStyle4.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle4.SelectionBackColor = Color.WhiteSmoke
        DataGridViewCellStyle4.SelectionForeColor = Color.DodgerBlue
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dtStudentDS.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dtStudentDS.RowHeadersVisible = False
        dtStudentDS.RowHeadersWidth = 51
        DataGridViewCellStyle5.ForeColor = Color.DodgerBlue
        dtStudentDS.RowsDefaultCellStyle = DataGridViewCellStyle5
        dtStudentDS.ScrollBars = ScrollBars.Vertical
        dtStudentDS.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtStudentDS.Size = New Size(1405, 416)
        dtStudentDS.TabIndex = 2
        ' 
        ' Col1
        ' 
        Col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Col1.HeaderText = "Student ID"
        Col1.MinimumWidth = 6
        Col1.Name = "Col1"
        Col1.ReadOnly = True
        Col1.Width = 113
        ' 
        ' Col2
        ' 
        Col2.HeaderText = "Lastname"
        Col2.MinimumWidth = 6
        Col2.Name = "Col2"
        Col2.ReadOnly = True
        Col2.Width = 108
        ' 
        ' Col3
        ' 
        Col3.HeaderText = "Firstname"
        Col3.MinimumWidth = 6
        Col3.Name = "Col3"
        Col3.ReadOnly = True
        Col3.Width = 106
        ' 
        ' Col4
        ' 
        Col4.HeaderText = "Middlename"
        Col4.MinimumWidth = 6
        Col4.Name = "Col4"
        Col4.ReadOnly = True
        Col4.Width = 131
        ' 
        ' Col5
        ' 
        Col5.HeaderText = "Year"
        Col5.MinimumWidth = 6
        Col5.Name = "Col5"
        Col5.ReadOnly = True
        Col5.Width = 70
        ' 
        ' Col6
        ' 
        Col6.HeaderText = "Program"
        Col6.MinimumWidth = 6
        Col6.Name = "Col6"
        Col6.ReadOnly = True
        ' 
        ' Col7
        ' 
        Col7.HeaderText = "Section"
        Col7.MinimumWidth = 6
        Col7.Name = "Col7"
        Col7.ReadOnly = True
        Col7.Width = 92
        ' 
        ' Col8
        ' 
        Col8.HeaderText = "Gender"
        Col8.MinimumWidth = 6
        Col8.Name = "Col8"
        Col8.ReadOnly = True
        Col8.Width = 95
        ' 
        ' Col9
        ' 
        Col9.HeaderText = "Birthdate"
        Col9.MinimumWidth = 6
        Col9.Name = "Col9"
        Col9.ReadOnly = True
        Col9.Width = 104
        ' 
        ' Col10
        ' 
        Col10.HeaderText = "Religion"
        Col10.MinimumWidth = 6
        Col10.Name = "Col10"
        Col10.ReadOnly = True
        Col10.Width = 95
        ' 
        ' Col11
        ' 
        Col11.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Col11.HeaderText = "Address"
        Col11.MinimumWidth = 6
        Col11.Name = "Col11"
        Col11.ReadOnly = True
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.Right
        Panel4.BackColor = Color.WhiteSmoke
        Panel4.Location = New Point(2197, 58)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(378, 40)
        Panel4.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(51), CByte(102))
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Panel4)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1405, 104)
        Panel1.TabIndex = 5
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(bttnImport)
        Panel2.Controls.Add(bttnSave)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 520)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1405, 62)
        Panel2.TabIndex = 3
        ' 
        ' bttnImport
        ' 
        bttnImport.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        bttnImport.Cursor = Cursors.Hand
        bttnImport.Location = New Point(1152, 16)
        bttnImport.Name = "bttnImport"
        bttnImport.Size = New Size(106, 29)
        bttnImport.TabIndex = 0
        bttnImport.Text = "Import"
        bttnImport.UseVisualStyleBackColor = True
        ' 
        ' bttnSave
        ' 
        bttnSave.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        bttnSave.Cursor = Cursors.Hand
        bttnSave.Location = New Point(1278, 16)
        bttnSave.Name = "bttnSave"
        bttnSave.Size = New Size(106, 29)
        bttnSave.TabIndex = 0
        bttnSave.Text = "Save"
        bttnSave.UseVisualStyleBackColor = True
        ' 
        ' ImportForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1405, 582)
        Controls.Add(dtStudentDS)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Font = New Font("Century Gothic", 9F)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "ImportForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Import Data"
        CType(dtStudentDS, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents dtStudentDS As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bttnImport As Button
    Friend WithEvents bttnSave As Button
    Friend WithEvents Col1 As DataGridViewTextBoxColumn
    Friend WithEvents Col2 As DataGridViewTextBoxColumn
    Friend WithEvents Col3 As DataGridViewTextBoxColumn
    Friend WithEvents Col4 As DataGridViewTextBoxColumn
    Friend WithEvents Col5 As DataGridViewTextBoxColumn
    Friend WithEvents Col6 As DataGridViewTextBoxColumn
    Friend WithEvents Col7 As DataGridViewTextBoxColumn
    Friend WithEvents Col8 As DataGridViewTextBoxColumn
    Friend WithEvents Col9 As DataGridViewTextBoxColumn
    Friend WithEvents Col10 As DataGridViewTextBoxColumn
    Friend WithEvents Col11 As DataGridViewTextBoxColumn
End Class
