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
        btnBrowse = New Button()
        btnCetak = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtAlamat = New TextBox()
        txtTelepon = New TextBox()
        txtUmur = New TextBox()
        txtNama = New TextBox()
        dtpTanggalLahir = New DateTimePicker()
        gbJenisKelamin = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        gbHobby = New GroupBox()
        cbDIY = New CheckBox()
        cbFotografi = New CheckBox()
        cbCoding = New CheckBox()
        cbHiking = New CheckBox()
        cbGaming = New CheckBox()
        cbOlahraga = New CheckBox()
        cbMemasak = New CheckBox()
        cbMancing = New CheckBox()
        cbMenyanyi = New CheckBox()
        cbMembaca = New CheckBox()
        cbMenulis = New CheckBox()
        cbInvestasi = New CheckBox()
        OpenFileDialog1 = New OpenFileDialog()
        PictureBox1 = New PictureBox()
        gbJenisKelamin.SuspendLayout()
        gbHobby.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(57, 408)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(367, 408)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(289, 29)
        btnCetak.TabIndex = 2
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(246, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 3
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(246, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 20)
        Label2.TabIndex = 4
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(246, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 5
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(246, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 6
        Label4.Text = "No Telepon"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(246, 201)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 20)
        Label5.TabIndex = 7
        Label5.Text = "Alamat"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(367, 194)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(262, 27)
        txtAlamat.TabIndex = 8
        ' 
        ' txtTelepon
        ' 
        txtTelepon.Location = New Point(367, 150)
        txtTelepon.Name = "txtTelepon"
        txtTelepon.Size = New Size(262, 27)
        txtTelepon.TabIndex = 9
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(367, 63)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(262, 27)
        txtUmur.TabIndex = 10
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(367, 21)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(262, 27)
        txtNama.TabIndex = 11
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(367, 106)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(262, 27)
        dtpTanggalLahir.TabIndex = 12
        ' 
        ' gbJenisKelamin
        ' 
        gbJenisKelamin.Controls.Add(rbPerempuan)
        gbJenisKelamin.Controls.Add(rbLaki)
        gbJenisKelamin.Location = New Point(246, 234)
        gbJenisKelamin.Name = "gbJenisKelamin"
        gbJenisKelamin.Size = New Size(215, 153)
        gbJenisKelamin.TabIndex = 13
        gbJenisKelamin.TabStop = False
        gbJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(6, 87)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 15
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(6, 47)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(86, 24)
        rbLaki.TabIndex = 15
        rbLaki.TabStop = True
        rbLaki.Text = "Laki Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' gbHobby
        ' 
        gbHobby.Controls.Add(cbDIY)
        gbHobby.Controls.Add(cbFotografi)
        gbHobby.Controls.Add(cbCoding)
        gbHobby.Controls.Add(cbHiking)
        gbHobby.Controls.Add(cbGaming)
        gbHobby.Controls.Add(cbOlahraga)
        gbHobby.Controls.Add(cbMemasak)
        gbHobby.Controls.Add(cbMancing)
        gbHobby.Controls.Add(cbMenyanyi)
        gbHobby.Controls.Add(cbMembaca)
        gbHobby.Controls.Add(cbMenulis)
        gbHobby.Controls.Add(cbInvestasi)
        gbHobby.Location = New Point(467, 234)
        gbHobby.Name = "gbHobby"
        gbHobby.Size = New Size(327, 153)
        gbHobby.TabIndex = 14
        gbHobby.TabStop = False
        gbHobby.Text = "Hobby"
        ' 
        ' cbDIY
        ' 
        cbDIY.AutoSize = True
        cbDIY.Location = New Point(215, 123)
        cbDIY.Name = "cbDIY"
        cbDIY.Size = New Size(54, 24)
        cbDIY.TabIndex = 25
        cbDIY.Text = "DIY"
        cbDIY.UseVisualStyleBackColor = True
        ' 
        ' cbFotografi
        ' 
        cbFotografi.AutoSize = True
        cbFotografi.Location = New Point(106, 123)
        cbFotografi.Name = "cbFotografi"
        cbFotografi.Size = New Size(92, 24)
        cbFotografi.TabIndex = 24
        cbFotografi.Text = "Fotografi"
        cbFotografi.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Location = New Point(0, 123)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(79, 24)
        cbCoding.TabIndex = 23
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbHiking
        ' 
        cbHiking.AutoSize = True
        cbHiking.Location = New Point(215, 89)
        cbHiking.Name = "cbHiking"
        cbHiking.Size = New Size(74, 24)
        cbHiking.TabIndex = 15
        cbHiking.Text = "Hiking"
        cbHiking.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(0, 23)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(83, 24)
        cbGaming.TabIndex = 15
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Location = New Point(0, 57)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(92, 24)
        cbOlahraga.TabIndex = 16
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbMemasak
        ' 
        cbMemasak.AutoSize = True
        cbMemasak.Location = New Point(0, 87)
        cbMemasak.Name = "cbMemasak"
        cbMemasak.Size = New Size(94, 24)
        cbMemasak.TabIndex = 17
        cbMemasak.Text = "Memasak"
        cbMemasak.UseVisualStyleBackColor = True
        ' 
        ' cbMancing
        ' 
        cbMancing.AutoSize = True
        cbMancing.Location = New Point(106, 23)
        cbMancing.Name = "cbMancing"
        cbMancing.Size = New Size(88, 24)
        cbMancing.TabIndex = 18
        cbMancing.Text = "Mancing"
        cbMancing.UseVisualStyleBackColor = True
        ' 
        ' cbMenyanyi
        ' 
        cbMenyanyi.AutoSize = True
        cbMenyanyi.Location = New Point(106, 57)
        cbMenyanyi.Name = "cbMenyanyi"
        cbMenyanyi.Size = New Size(94, 24)
        cbMenyanyi.TabIndex = 19
        cbMenyanyi.Text = "Menyanyi"
        cbMenyanyi.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(106, 88)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(97, 24)
        cbMembaca.TabIndex = 20
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.Location = New Point(218, 23)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(82, 24)
        cbMenulis.TabIndex = 21
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' cbInvestasi
        ' 
        cbInvestasi.AutoSize = True
        cbInvestasi.Location = New Point(216, 57)
        cbInvestasi.Name = "cbInvestasi"
        cbInvestasi.Size = New Size(87, 24)
        cbInvestasi.TabIndex = 22
        cbInvestasi.Text = "Investasi"
        cbInvestasi.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ActiveBorder
        PictureBox1.Location = New Point(12, 39)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(216, 342)
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(gbHobby)
        Controls.Add(gbJenisKelamin)
        Controls.Add(dtpTanggalLahir)
        Controls.Add(txtNama)
        Controls.Add(txtUmur)
        Controls.Add(txtTelepon)
        Controls.Add(txtAlamat)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCetak)
        Controls.Add(btnBrowse)
        Name = "Form1"
        Text = "SIM Bikini Bottom"
        gbJenisKelamin.ResumeLayout(False)
        gbJenisKelamin.PerformLayout()
        gbHobby.ResumeLayout(False)
        gbHobby.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents gbJenisKelamin As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents gbHobby As GroupBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMemasak As CheckBox
    Friend WithEvents cbMancing As CheckBox
    Friend WithEvents cbMenyanyi As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents cbInvestasi As CheckBox
    Friend WithEvents cbDIY As CheckBox
    Friend WithEvents cbFotografi As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbHiking As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox

End Class
