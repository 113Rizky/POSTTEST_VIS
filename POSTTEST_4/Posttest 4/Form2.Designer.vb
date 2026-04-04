<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInput
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
        components = New ComponentModel.Container()
        TabControl1 = New TabControl()
        tabDataUtama = New TabPage()
        btnKeTabKontak = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        cmbKomunitas = New ComboBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        dtpTanggalLahir = New DateTimePicker()
        txtIDAnggota = New TextBox()
        txtNama = New TextBox()
        tabKontakInfo = New TabPage()
        btnKeTabProfil = New Button()
        btnKembaliKeTabUtama = New Button()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        mtbNoHP = New MaskedTextBox()
        tabProfilAktivitas = New TabPage()
        Panel1 = New Panel()
        picFoto = New PictureBox()
        grpPeran = New GroupBox()
        rbKetua = New RadioButton()
        rbKoordinator = New RadioButton()
        rbAnggota = New RadioButton()
        rbAdmin = New RadioButton()
        Label11 = New Label()
        chkEvent = New CheckBox()
        chkRelawan = New CheckBox()
        chkEditing = New CheckBox()
        chkFotografi = New CheckBox()
        chkPublicSpeaking = New CheckBox()
        chkMenulis = New CheckBox()
        chkNgoding = New CheckBox()
        chkDesain = New CheckBox()
        Label10 = New Label()
        btnSimpanCetak = New Button()
        btnBrowse = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        TabControl1.SuspendLayout()
        tabDataUtama.SuspendLayout()
        tabKontakInfo.SuspendLayout()
        tabProfilAktivitas.SuspendLayout()
        Panel1.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        grpPeran.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabDataUtama)
        TabControl1.Controls.Add(tabKontakInfo)
        TabControl1.Controls.Add(tabProfilAktivitas)
        TabControl1.Location = New Point(37, 23)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(654, 383)
        TabControl1.TabIndex = 0
        ' 
        ' tabDataUtama
        ' 
        tabDataUtama.BackColor = Color.Transparent
        tabDataUtama.Controls.Add(btnKeTabKontak)
        tabDataUtama.Controls.Add(Label5)
        tabDataUtama.Controls.Add(Label4)
        tabDataUtama.Controls.Add(Label3)
        tabDataUtama.Controls.Add(Label2)
        tabDataUtama.Controls.Add(Label1)
        tabDataUtama.Controls.Add(cmbKomunitas)
        tabDataUtama.Controls.Add(rbPerempuan)
        tabDataUtama.Controls.Add(rbLaki)
        tabDataUtama.Controls.Add(dtpTanggalLahir)
        tabDataUtama.Controls.Add(txtIDAnggota)
        tabDataUtama.Controls.Add(txtNama)
        tabDataUtama.Location = New Point(4, 29)
        tabDataUtama.Name = "tabDataUtama"
        tabDataUtama.Padding = New Padding(3)
        tabDataUtama.Size = New Size(646, 350)
        tabDataUtama.TabIndex = 0
        tabDataUtama.Text = "Data Utama"
        ' 
        ' btnKeTabKontak
        ' 
        btnKeTabKontak.BackColor = Color.Lime
        btnKeTabKontak.Location = New Point(233, 292)
        btnKeTabKontak.Name = "btnKeTabKontak"
        btnKeTabKontak.Size = New Size(94, 29)
        btnKeTabKontak.TabIndex = 1
        btnKeTabKontak.Text = "Next >>"
        btnKeTabKontak.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 237)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 20)
        Label5.TabIndex = 11
        Label5.Text = "Komunitas/Divisi    :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(22, 186)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 20)
        Label4.TabIndex = 10
        Label4.Text = "Jenis Kelamin          :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(137, 20)
        Label3.TabIndex = 9
        Label3.Text = "ID Anggota            :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 20)
        Label2.TabIndex = 8
        Label2.Text = "Tanggal Lahir          :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 20)
        Label1.TabIndex = 7
        Label1.Text = "Nama                     :"
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.FormattingEnabled = True
        cmbKomunitas.Location = New Point(184, 229)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(250, 28)
        cmbKomunitas.TabIndex = 6
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(297, 184)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 5
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(184, 184)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(85, 24)
        rbLaki.TabIndex = 4
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(184, 134)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(250, 27)
        dtpTanggalLahir.TabIndex = 3
        ' 
        ' txtIDAnggota
        ' 
        txtIDAnggota.Location = New Point(184, 91)
        txtIDAnggota.Name = "txtIDAnggota"
        txtIDAnggota.PlaceholderText = "ID Anggota"
        txtIDAnggota.Size = New Size(250, 27)
        txtIDAnggota.TabIndex = 2
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(184, 45)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama"
        txtNama.Size = New Size(250, 27)
        txtNama.TabIndex = 1
        ' 
        ' tabKontakInfo
        ' 
        tabKontakInfo.Controls.Add(btnKeTabProfil)
        tabKontakInfo.Controls.Add(btnKembaliKeTabUtama)
        tabKontakInfo.Controls.Add(Label8)
        tabKontakInfo.Controls.Add(Label7)
        tabKontakInfo.Controls.Add(Label6)
        tabKontakInfo.Controls.Add(txtAlamat)
        tabKontakInfo.Controls.Add(txtEmail)
        tabKontakInfo.Controls.Add(mtbNoHP)
        tabKontakInfo.Location = New Point(4, 29)
        tabKontakInfo.Name = "tabKontakInfo"
        tabKontakInfo.Padding = New Padding(3)
        tabKontakInfo.Size = New Size(646, 350)
        tabKontakInfo.TabIndex = 1
        tabKontakInfo.Text = "Kontak & Info"
        tabKontakInfo.UseVisualStyleBackColor = True
        ' 
        ' btnKeTabProfil
        ' 
        btnKeTabProfil.BackColor = Color.Lime
        btnKeTabProfil.Location = New Point(309, 272)
        btnKeTabProfil.Name = "btnKeTabProfil"
        btnKeTabProfil.Size = New Size(94, 29)
        btnKeTabProfil.TabIndex = 7
        btnKeTabProfil.Text = "Next >>"
        btnKeTabProfil.UseVisualStyleBackColor = False
        ' 
        ' btnKembaliKeTabUtama
        ' 
        btnKembaliKeTabUtama.BackColor = Color.Red
        btnKembaliKeTabUtama.Location = New Point(170, 272)
        btnKembaliKeTabUtama.Name = "btnKembaliKeTabUtama"
        btnKembaliKeTabUtama.Size = New Size(94, 29)
        btnKembaliKeTabUtama.TabIndex = 6
        btnKembaliKeTabUtama.Text = "<< Back"
        btnKembaliKeTabUtama.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(15, 161)
        Label8.Name = "Label8"
        Label8.Size = New Size(140, 20)
        Label8.TabIndex = 5
        Label8.Text = "Alamat                    :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(15, 109)
        Label7.Name = "Label7"
        Label7.Size = New Size(141, 20)
        Label7.TabIndex = 4
        Label7.Text = "Email                       :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 63)
        Label6.Name = "Label6"
        Label6.Size = New Size(140, 20)
        Label6.TabIndex = 3
        Label6.Text = "Nomor Telepon      :"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(170, 158)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Alamat"
        txtAlamat.Size = New Size(233, 83)
        txtAlamat.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(170, 102)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(233, 27)
        txtEmail.TabIndex = 1
        ' 
        ' mtbNoHP
        ' 
        mtbNoHP.Location = New Point(170, 56)
        mtbNoHP.Mask = "000.000.000.000"
        mtbNoHP.Name = "mtbNoHP"
        mtbNoHP.Size = New Size(233, 27)
        mtbNoHP.TabIndex = 0
        ' 
        ' tabProfilAktivitas
        ' 
        tabProfilAktivitas.Controls.Add(Panel1)
        tabProfilAktivitas.Controls.Add(grpPeran)
        tabProfilAktivitas.Controls.Add(Label11)
        tabProfilAktivitas.Controls.Add(chkEvent)
        tabProfilAktivitas.Controls.Add(chkRelawan)
        tabProfilAktivitas.Controls.Add(chkEditing)
        tabProfilAktivitas.Controls.Add(chkFotografi)
        tabProfilAktivitas.Controls.Add(chkPublicSpeaking)
        tabProfilAktivitas.Controls.Add(chkMenulis)
        tabProfilAktivitas.Controls.Add(chkNgoding)
        tabProfilAktivitas.Controls.Add(chkDesain)
        tabProfilAktivitas.Controls.Add(Label10)
        tabProfilAktivitas.Controls.Add(btnSimpanCetak)
        tabProfilAktivitas.Controls.Add(btnBrowse)
        tabProfilAktivitas.Location = New Point(4, 29)
        tabProfilAktivitas.Name = "tabProfilAktivitas"
        tabProfilAktivitas.Padding = New Padding(3)
        tabProfilAktivitas.Size = New Size(646, 350)
        tabProfilAktivitas.TabIndex = 2
        tabProfilAktivitas.Text = "Profil & Aktivitas"
        tabProfilAktivitas.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkGray
        Panel1.Controls.Add(picFoto)
        Panel1.Location = New Point(6, 6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(226, 208)
        Panel1.TabIndex = 1
        ' 
        ' picFoto
        ' 
        picFoto.Location = New Point(12, 12)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(201, 184)
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' grpPeran
        ' 
        grpPeran.Controls.Add(rbKetua)
        grpPeran.Controls.Add(rbKoordinator)
        grpPeran.Controls.Add(rbAnggota)
        grpPeran.Controls.Add(rbAdmin)
        grpPeran.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpPeran.Location = New Point(243, 11)
        grpPeran.Name = "grpPeran"
        grpPeran.Size = New Size(397, 59)
        grpPeran.TabIndex = 18
        grpPeran.TabStop = False
        grpPeran.Text = "Peran"
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbKetua.Location = New Point(13, 23)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(70, 23)
        rbKetua.TabIndex = 3
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' rbKoordinator
        ' 
        rbKoordinator.AutoSize = True
        rbKoordinator.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbKoordinator.Location = New Point(277, 23)
        rbKoordinator.Name = "rbKoordinator"
        rbKoordinator.Size = New Size(114, 23)
        rbKoordinator.TabIndex = 6
        rbKoordinator.TabStop = True
        rbKoordinator.Text = "Koordinator"
        rbKoordinator.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbAnggota.Location = New Point(96, 23)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(86, 23)
        rbAnggota.TabIndex = 4
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbAdmin.Location = New Point(190, 23)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(75, 23)
        rbAdmin.TabIndex = 5
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(339, 97)
        Label11.Name = "Label11"
        Label11.Size = New Size(141, 20)
        Label11.TabIndex = 17
        Label11.Text = "Aktivitas / Minat"
        ' 
        ' chkEvent
        ' 
        chkEvent.AutoSize = True
        chkEvent.Location = New Point(537, 162)
        chkEvent.Name = "chkEvent"
        chkEvent.Size = New Size(67, 24)
        chkEvent.TabIndex = 16
        chkEvent.Text = "Event"
        chkEvent.UseVisualStyleBackColor = True
        ' 
        ' chkRelawan
        ' 
        chkRelawan.AutoSize = True
        chkRelawan.Location = New Point(537, 132)
        chkRelawan.Name = "chkRelawan"
        chkRelawan.Size = New Size(87, 24)
        chkRelawan.TabIndex = 15
        chkRelawan.Text = "Relawan"
        chkRelawan.UseVisualStyleBackColor = True
        ' 
        ' chkEditing
        ' 
        chkEditing.AutoSize = True
        chkEditing.Location = New Point(388, 192)
        chkEditing.Name = "chkEditing"
        chkEditing.Size = New Size(78, 24)
        chkEditing.TabIndex = 14
        chkEditing.Text = "Editing"
        chkEditing.UseVisualStyleBackColor = True
        ' 
        ' chkFotografi
        ' 
        chkFotografi.AutoSize = True
        chkFotografi.Location = New Point(388, 162)
        chkFotografi.Name = "chkFotografi"
        chkFotografi.Size = New Size(92, 24)
        chkFotografi.TabIndex = 13
        chkFotografi.Text = "Fotografi"
        chkFotografi.UseVisualStyleBackColor = True
        ' 
        ' chkPublicSpeaking
        ' 
        chkPublicSpeaking.AutoSize = True
        chkPublicSpeaking.Location = New Point(388, 132)
        chkPublicSpeaking.Name = "chkPublicSpeaking"
        chkPublicSpeaking.Size = New Size(136, 24)
        chkPublicSpeaking.TabIndex = 12
        chkPublicSpeaking.Text = "Public Speaking"
        chkPublicSpeaking.UseVisualStyleBackColor = True
        ' 
        ' chkMenulis
        ' 
        chkMenulis.AutoSize = True
        chkMenulis.Location = New Point(256, 192)
        chkMenulis.Name = "chkMenulis"
        chkMenulis.Size = New Size(82, 24)
        chkMenulis.TabIndex = 11
        chkMenulis.Text = "Menulis"
        chkMenulis.UseVisualStyleBackColor = True
        ' 
        ' chkNgoding
        ' 
        chkNgoding.AutoSize = True
        chkNgoding.Location = New Point(256, 162)
        chkNgoding.Name = "chkNgoding"
        chkNgoding.Size = New Size(90, 24)
        chkNgoding.TabIndex = 10
        chkNgoding.Text = "Ngoding"
        chkNgoding.UseVisualStyleBackColor = True
        ' 
        ' chkDesain
        ' 
        chkDesain.AutoSize = True
        chkDesain.Location = New Point(256, 132)
        chkDesain.Name = "chkDesain"
        chkDesain.Size = New Size(76, 24)
        chkDesain.TabIndex = 9
        chkDesain.Text = "Desain"
        chkDesain.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(232, 73)
        Label10.Name = "Label10"
        Label10.Size = New Size(411, 20)
        Label10.TabIndex = 8
        Label10.Text = "-------------------------------------------------------------------"
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.BackColor = Color.Lime
        btnSimpanCetak.Location = New Point(330, 278)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(177, 29)
        btnSimpanCetak.TabIndex = 2
        btnSimpanCetak.Text = "Simpan dan Cetak Kartu"
        btnSimpanCetak.UseVisualStyleBackColor = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.Yellow
        btnBrowse.Location = New Point(64, 220)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse Foto"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' FormInput
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Name = "FormInput"
        Text = "Form Input"
        TabControl1.ResumeLayout(False)
        tabDataUtama.ResumeLayout(False)
        tabDataUtama.PerformLayout()
        tabKontakInfo.ResumeLayout(False)
        tabKontakInfo.PerformLayout()
        tabProfilAktivitas.ResumeLayout(False)
        tabProfilAktivitas.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        grpPeran.ResumeLayout(False)
        grpPeran.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabDataUtama As TabPage
    Friend WithEvents tabKontakInfo As TabPage
    Friend WithEvents tabProfilAktivitas As TabPage
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents txtIDAnggota As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnKeTabKontak As Button
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtbNoHP As MaskedTextBox
    Friend WithEvents btnKeTabProfil As Button
    Friend WithEvents btnKembaliKeTabUtama As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents rbKoordinator As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents chkEvent As CheckBox
    Friend WithEvents chkRelawan As CheckBox
    Friend WithEvents chkEditing As CheckBox
    Friend WithEvents chkFotografi As CheckBox
    Friend WithEvents chkPublicSpeaking As CheckBox
    Friend WithEvents chkMenulis As CheckBox
    Friend WithEvents chkNgoding As CheckBox
    Friend WithEvents chkDesain As CheckBox
    Friend WithEvents grpPeran As GroupBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Panel1 As Panel
End Class
