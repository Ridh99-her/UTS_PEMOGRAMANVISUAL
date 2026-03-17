<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        picLogo = New PictureBox()
        lblUniv = New Label()
        lblIjazah = New Label()
        lblNama = New Label()
        lblNIM = New Label()
        lblProdi = New Label()
        lblAngkatan = New Label()
        lblPredikat = New Label()
        btnKembali = New Button()
        btnExit = New Button()
        Panel1 = New Panel()
        lblKementrian = New Label()
        lblTanggal = New Label()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(-43, -26)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(805, 449)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' lblUniv
        ' 
        lblUniv.BackColor = Color.Transparent
        lblUniv.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUniv.Location = New Point(228, 95)
        lblUniv.Name = "lblUniv"
        lblUniv.Size = New Size(311, 24)
        lblUniv.TabIndex = 1
        lblUniv.Text = "UNIVERSITAS MULAWARMAN"
        ' 
        ' lblIjazah
        ' 
        lblIjazah.AutoSize = True
        lblIjazah.BackColor = Color.Transparent
        lblIjazah.Font = New Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIjazah.Location = New Point(327, 119)
        lblIjazah.Name = "lblIjazah"
        lblIjazah.Size = New Size(119, 32)
        lblIjazah.TabIndex = 2
        lblIjazah.Text = "IJAZAH"
        ' 
        ' lblNama
        ' 
        lblNama.BackColor = Color.Transparent
        lblNama.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(299, 168)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(167, 26)
        lblNama.TabIndex = 3
        lblNama.Text = "Label3"
        lblNama.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblNIM
        ' 
        lblNIM.BackColor = Color.Transparent
        lblNIM.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNIM.Location = New Point(274, 194)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(220, 24)
        lblNIM.TabIndex = 4
        lblNIM.Text = "Label4"
        lblNIM.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblProdi
        ' 
        lblProdi.AutoSize = True
        lblProdi.BackColor = Color.Transparent
        lblProdi.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProdi.Location = New Point(336, 218)
        lblProdi.Name = "lblProdi"
        lblProdi.Size = New Size(83, 26)
        lblProdi.TabIndex = 5
        lblProdi.Text = "Label5"
        ' 
        ' lblAngkatan
        ' 
        lblAngkatan.AutoSize = True
        lblAngkatan.BackColor = Color.Transparent
        lblAngkatan.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAngkatan.Location = New Point(336, 267)
        lblAngkatan.Name = "lblAngkatan"
        lblAngkatan.Size = New Size(83, 26)
        lblAngkatan.TabIndex = 6
        lblAngkatan.Text = "Label6"
        ' 
        ' lblPredikat
        ' 
        lblPredikat.BackColor = Color.Transparent
        lblPredikat.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPredikat.Location = New Point(77, 330)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(799, 73)
        lblPredikat.TabIndex = 7
        lblPredikat.Text = "Label7"
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(698, 168)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(75, 23)
        btnKembali.TabIndex = 8
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(698, 139)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 9
        btnExit.Text = "Keluar"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(lblKementrian)
        Panel1.Controls.Add(lblTanggal)
        Panel1.Controls.Add(btnExit)
        Panel1.Controls.Add(btnKembali)
        Panel1.Controls.Add(lblPredikat)
        Panel1.Controls.Add(lblAngkatan)
        Panel1.Controls.Add(lblProdi)
        Panel1.Controls.Add(lblNIM)
        Panel1.Controls.Add(lblNama)
        Panel1.Controls.Add(lblIjazah)
        Panel1.Controls.Add(lblUniv)
        Panel1.Controls.Add(picLogo)
        Panel1.Location = New Point(2, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(799, 500)
        Panel1.TabIndex = 0
        ' 
        ' lblKementrian
        ' 
        lblKementrian.AutoSize = True
        lblKementrian.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKementrian.Location = New Point(228, 71)
        lblKementrian.Name = "lblKementrian"
        lblKementrian.Size = New Size(293, 24)
        lblKementrian.TabIndex = 12
        lblKementrian.Text = "KEMENTRIAN PENDIDIKAN"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.BackColor = Color.Transparent
        lblTanggal.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTanggal.Location = New Point(256, 244)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(517, 23)
        lblTanggal.TabIndex = 11
        lblTanggal.Text = "Lulus pada tanggal : "
        lblTanggal.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form3"
        Text = "Form3"
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblUniv As Label
    Friend WithEvents lblIjazah As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNIM As Label
    Friend WithEvents lblProdi As Label
    Friend WithEvents lblAngkatan As Label
    Friend WithEvents lblPredikat As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblKementrian As Label
End Class
