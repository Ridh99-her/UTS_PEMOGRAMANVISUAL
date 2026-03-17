<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        txtNama = New TextBox()
        txtNIM = New TextBox()
        txtIPK = New TextBox()
        btnCetak = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtAngkatan = New TextBox()
        Label5 = New Label()
        btnKembali = New Button()
        txtProdi = New ComboBox()
        SuspendLayout()
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(316, 52)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(100, 23)
        txtNama.TabIndex = 0
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(316, 111)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(100, 23)
        txtNIM.TabIndex = 1
        ' 
        ' txtIPK
        ' 
        txtIPK.Location = New Point(316, 297)
        txtIPK.Name = "txtIPK"
        txtIPK.Size = New Size(100, 23)
        txtIPK.TabIndex = 2
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(575, 172)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(127, 23)
        btnCetak.TabIndex = 3
        btnCetak.Text = "CETAK IJAZAH"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(124, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 22)
        Label1.TabIndex = 4
        Label1.Text = "Nama Mahasiswa"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Black
        Label2.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(124, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 22)
        Label2.TabIndex = 5
        Label2.Text = "NIM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(124, 298)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 22)
        Label3.TabIndex = 6
        Label3.Text = "IPK"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Black
        Label4.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(124, 171)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 22)
        Label4.TabIndex = 8
        Label4.Text = "Program Studi"
        ' 
        ' txtAngkatan
        ' 
        txtAngkatan.Location = New Point(316, 236)
        txtAngkatan.Name = "txtAngkatan"
        txtAngkatan.Size = New Size(100, 23)
        txtAngkatan.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Black
        Label5.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(128, 247)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 22)
        Label5.TabIndex = 10
        Label5.Text = "Angkatan"
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(588, 246)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(75, 23)
        btnKembali.TabIndex = 11
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' txtProdi
        ' 
        txtProdi.FormattingEnabled = True
        txtProdi.Location = New Point(316, 171)
        txtProdi.Name = "txtProdi"
        txtProdi.Size = New Size(121, 23)
        txtProdi.TabIndex = 12
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.Black
        ClientSize = New Size(800, 450)
        Controls.Add(txtProdi)
        Controls.Add(btnKembali)
        Controls.Add(Label5)
        Controls.Add(txtAngkatan)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCetak)
        Controls.Add(txtIPK)
        Controls.Add(txtNIM)
        Controls.Add(txtNama)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents btnCetak As Button

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAngkatan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents txtProdi As ComboBox
End Class
