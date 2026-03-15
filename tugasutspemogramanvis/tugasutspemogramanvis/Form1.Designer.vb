<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        piclogo = New PictureBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnClose = New Button()
        CType(piclogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' piclogo
        ' 
        piclogo.Image = CType(resources.GetObject("piclogo.Image"), Image)
        piclogo.Location = New Point(81, 30)
        piclogo.Name = "piclogo"
        piclogo.Size = New Size(149, 196)
        piclogo.SizeMode = PictureBoxSizeMode.Zoom
        piclogo.TabIndex = 0
        piclogo.TabStop = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(321, 57)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Ketik Username...."
        txtUsername.Size = New Size(100, 23)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(321, 124)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(100, 23)
        txtPassword.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.Highlight
        btnLogin.Cursor = Cursors.Hand
        btnLogin.Location = New Point(321, 203)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 3
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnClose.Location = New Point(433, 203)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 4
        btnClose.Text = "CLOSE"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOliveGreen
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(piclogo)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Login Mahasiswa Unmul"
        CType(piclogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents piclogo As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnClose As Button

End Class
