<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginScreen))
        Panel1 = New Panel()
        Panel3 = New Panel()
        bttnReveal = New Button()
        txtPass = New TextBox()
        Panel2 = New Panel()
        txtUserN = New TextBox()
        loginBttn = New Button()
        cancelBttn = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(51), CByte(102))
        resources.ApplyResources(Panel1, "Panel1")
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(loginBttn)
        Panel1.Controls.Add(cancelBttn)
        Panel1.Name = "Panel1"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.WhiteSmoke
        Panel3.Controls.Add(bttnReveal)
        Panel3.Controls.Add(txtPass)
        resources.ApplyResources(Panel3, "Panel3")
        Panel3.Name = "Panel3"
        ' 
        ' bttnReveal
        ' 
        bttnReveal.BackColor = Color.Transparent
        resources.ApplyResources(bttnReveal, "bttnReveal")
        bttnReveal.Cursor = Cursors.Hand
        bttnReveal.FlatAppearance.BorderSize = 0
        bttnReveal.ForeColor = SystemColors.ControlText
        bttnReveal.Name = "bttnReveal"
        bttnReveal.UseVisualStyleBackColor = False
        ' 
        ' txtPass
        ' 
        txtPass.AllowDrop = True
        txtPass.BackColor = Color.WhiteSmoke
        txtPass.BorderStyle = BorderStyle.None
        txtPass.Cursor = Cursors.Hand
        resources.ApplyResources(txtPass, "txtPass")
        txtPass.Name = "txtPass"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.WhiteSmoke
        Panel2.Controls.Add(txtUserN)
        resources.ApplyResources(Panel2, "Panel2")
        Panel2.Name = "Panel2"
        ' 
        ' txtUserN
        ' 
        txtUserN.AllowDrop = True
        resources.ApplyResources(txtUserN, "txtUserN")
        txtUserN.BackColor = Color.WhiteSmoke
        txtUserN.BorderStyle = BorderStyle.None
        txtUserN.Cursor = Cursors.Hand
        txtUserN.Name = "txtUserN"
        ' 
        ' loginBttn
        ' 
        loginBttn.BackColor = Color.WhiteSmoke
        loginBttn.Cursor = Cursors.Hand
        resources.ApplyResources(loginBttn, "loginBttn")
        loginBttn.Name = "loginBttn"
        loginBttn.UseVisualStyleBackColor = False
        ' 
        ' cancelBttn
        ' 
        cancelBttn.BackColor = Color.WhiteSmoke
        cancelBttn.Cursor = Cursors.Hand
        resources.ApplyResources(cancelBttn, "cancelBttn")
        cancelBttn.Name = "cancelBttn"
        cancelBttn.UseVisualStyleBackColor = False
        ' 
        ' LoginScreen
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "LoginScreen"
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents loginBttn As Button
    Friend WithEvents cancelBttn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUserN As TextBox
    Private WithEvents Panel1 As Panel
    Friend WithEvents bttnReveal As Button

End Class
