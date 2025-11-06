<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainInt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainInt))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        BtnDelete = New Button()
        bttnImport = New Button()
        Panel4 = New Panel()
        bttnSearch = New Button()
        txtbxSearch = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        dtStudentDS = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        bttnEdit = New Button()
        bttnExit = New Button()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dtStudentDS, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(51), CByte(102))
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(BtnDelete)
        Panel1.Controls.Add(bttnImport)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1249, 104)
        Panel1.TabIndex = 0
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Anchor = AnchorStyles.Right
        BtnDelete.Cursor = Cursors.Hand
        BtnDelete.Font = New Font("Century Gothic", 10.2F)
        BtnDelete.Location = New Point(696, 56)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(94, 40)
        BtnDelete.TabIndex = 2
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' bttnImport
        ' 
        bttnImport.Anchor = AnchorStyles.Right
        bttnImport.Cursor = Cursors.Hand
        bttnImport.Font = New Font("Century Gothic", 10.2F)
        bttnImport.Location = New Point(800, 56)
        bttnImport.Name = "bttnImport"
        bttnImport.Size = New Size(94, 40)
        bttnImport.TabIndex = 2
        bttnImport.Text = "Import"
        bttnImport.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.Right
        Panel4.BackColor = Color.WhiteSmoke
        Panel4.Controls.Add(bttnSearch)
        Panel4.Controls.Add(txtbxSearch)
        Panel4.Location = New Point(904, 56)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(336, 40)
        Panel4.TabIndex = 2
        ' 
        ' bttnSearch
        ' 
        bttnSearch.BackColor = Color.Transparent
        bttnSearch.BackgroundImage = CType(resources.GetObject("bttnSearch.BackgroundImage"), Image)
        bttnSearch.BackgroundImageLayout = ImageLayout.Zoom
        bttnSearch.Cursor = Cursors.Hand
        bttnSearch.FlatAppearance.BorderSize = 0
        bttnSearch.FlatStyle = FlatStyle.Flat
        bttnSearch.ForeColor = Color.Transparent
        bttnSearch.Location = New Point(296, 4)
        bttnSearch.Name = "bttnSearch"
        bttnSearch.Size = New Size(32, 32)
        bttnSearch.TabIndex = 2
        bttnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtbxSearch
        ' 
        txtbxSearch.BackColor = Color.WhiteSmoke
        txtbxSearch.BorderStyle = BorderStyle.None
        txtbxSearch.Cursor = Cursors.IBeam
        txtbxSearch.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxSearch.Location = New Point(8, 9)
        txtbxSearch.Name = "txtbxSearch"
        txtbxSearch.PlaceholderText = "Search"
        txtbxSearch.Size = New Size(280, 19)
        txtbxSearch.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Calisto MT", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(88, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(574, 50)
        Label1.TabIndex = 1
        Label1.Text = "Student Information System"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Zoom
        Panel2.Location = New Point(8, 8)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(80, 80)
        Panel2.TabIndex = 0
        ' 
        ' dtStudentDS
        ' 
        dtStudentDS.AllowUserToAddRows = False
        dtStudentDS.AllowUserToDeleteRows = False
        dtStudentDS.AllowUserToResizeColumns = False
        dtStudentDS.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = Color.DodgerBlue
        dtStudentDS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dtStudentDS.BackgroundColor = Color.WhiteSmoke
        dtStudentDS.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        dtStudentDS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.DodgerBlue
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dtStudentDS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dtStudentDS.ColumnHeadersHeight = 25
        dtStudentDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dtStudentDS.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
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
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
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
        dtStudentDS.Size = New Size(1249, 408)
        dtStudentDS.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "#"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Resizable = DataGridViewTriState.True
        Column1.Width = 20
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "Student ID"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 127
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Lastname"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Firstname"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Middlename"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 150
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Year"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 125
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Program"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 125
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Section"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 125
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Gender"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 80
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Birthdate"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 125
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "Religion"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        Column11.Width = 125
        ' 
        ' Column12
        ' 
        Column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column12.HeaderText = "Address"
        Column12.MinimumWidth = 6
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        ' 
        ' bttnEdit
        ' 
        bttnEdit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        bttnEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink
        bttnEdit.Cursor = Cursors.Hand
        bttnEdit.Font = New Font("Century Gothic", 10.2F)
        bttnEdit.ImageAlign = ContentAlignment.MiddleLeft
        bttnEdit.Location = New Point(1136, 22)
        bttnEdit.Name = "bttnEdit"
        bttnEdit.Size = New Size(94, 32)
        bttnEdit.TabIndex = 2
        bttnEdit.Text = "Add"
        bttnEdit.UseVisualStyleBackColor = True
        ' 
        ' bttnExit
        ' 
        bttnExit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        bttnExit.Cursor = Cursors.Hand
        bttnExit.Font = New Font("Century Gothic", 10.2F)
        bttnExit.Location = New Point(1024, 22)
        bttnExit.Name = "bttnExit"
        bttnExit.Size = New Size(94, 32)
        bttnExit.TabIndex = 2
        bttnExit.Text = "Exit"
        bttnExit.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(bttnExit)
        Panel3.Controls.Add(bttnEdit)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 512)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1249, 70)
        Panel3.TabIndex = 3
        ' 
        ' MainInt
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(1249, 582)
        Controls.Add(dtStudentDS)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "MainInt"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainInt"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(dtStudentDS, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtStudentDS As DataGridView
    Friend WithEvents bttnEdit As Button
    Friend WithEvents bttnExit As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtbxSearch As TextBox
    Friend WithEvents bttnSearch As Button
    Friend WithEvents bttnImport As Button
    Friend WithEvents BtnDelete As Button
End Class
